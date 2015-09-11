@model IEnumerable<$rootnamespace$.Dtos.Samples.TestInfoDto>

@{
    ViewBag.Title = "View1";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h2>View1</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(model => model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Remark)
        </th>
        <th></th>
    </tr>

@foreach (var item in Model) {
    <tr>
        <td>
            @Html.DisplayFor(modelItem => item.Name)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.Remark)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", new { id=item.Id }) |
            @Html.ActionLink("Delete", "Delete", new { id=item.Id })
        </td>
    </tr>
}

</table>

<h3>Functions</h3>
@foreach (var item in ViewBag.Functions)
{
    <p>@item</p>
}

<h3>EntityInfos</h3>
@foreach (var item in ViewBag.EntityInfos)
{
    @item <br />
}
