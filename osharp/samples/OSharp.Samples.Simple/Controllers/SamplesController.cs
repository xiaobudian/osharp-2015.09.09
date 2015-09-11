using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OSharp.Utility.Data;
using OSharp.Samples.Simple.Contracts;
using OSharp.Samples.Simple.Dtos.Samples;
using OSharp.Utility.Extensions;
using OSharp.Web.Mvc.Security;


namespace OSharp.Samples.Simple.Controllers
{
    public class SamplesController : Controller
    {
        public ISamplesContract TestContract { get; set; }

        [AjaxOnly] //仅限ajax访问的功能，作此标记，影响功能信息的IsAjax属性
        [Description("示例-Ajax测试")] //功能名称，影响功能信息的Name属性
        public ActionResult TestAjax()
        {
            var value = new { Name = "OSharp" };
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        [Description("示例-首页")]
        public ActionResult Index()
        {
            TestInfoDto[] dtos = TestContract.TestInfos
                .Select(m => new TestInfoDto() {Id = m.Id, Name = m.Name, Remark = m.Remark})
                .ToArray();

            ViewBag.Functions = TestContract.Functions.ToList().Select(m=>m.ToJsonString());
            ViewBag.EntityInfos = TestContract.EntityInfos.ToList().Select(m => m.ToJsonString());
            

            return View(dtos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost] //初始化功能信息时，如果有同名Action，将会忽略标记了[HttpPost]的Action
        public ActionResult Create(TestInfoDto dto)
        {
            OperationResult result = TestContract.AddTestInfos(dto);
            if (result.ResultType != OperationResultType.Success)
            {
                ModelState.AddModelError("", result.Message);
                return View(dto);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            TestInfoDto dto = TestContract.TestInfos.Where(m => m.Id == id)
                .Select(m => new TestInfoDto() {Id = m.Id, Name = m.Name, Remark = m.Remark}).SingleOrDefault();

            return View(dto);
        }

        [HttpPost]
        public ActionResult Edit(TestInfoDto dto)
        {
            OperationResult result = TestContract.EditTestInfos(dto);
            if (result.ResultType != OperationResultType.Success)
            {
                ModelState.AddModelError("", result.Message);
                return View(dto);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            OperationResult result = TestContract.DeleteTestInfos(id);
            return RedirectToAction("Index");
        }

        public void Test()
        {
            var test = "";
            test.IsEmail();
            test.IsNullOrEmpty();
        }
    }
}