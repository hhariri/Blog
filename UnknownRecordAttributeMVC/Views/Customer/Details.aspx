<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Customer>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        <p>
            Id:
            <%= Html.Encode(Model.Id) %>
        </p>
        <p>
            Email:
            <%= Html.Encode(Model.Email) %>
        </p>
        <p>
            DateOfBirth:
            <%= Html.Encode(String.Format("{0:g}", Model.DateOfBirth)) %>
        </p>
        <p>
            IsActive:
            <%= Html.Encode(Model.IsActive) %>
        </p>
        <p>
            Title:
            <%= Html.Encode(Model.Title) %>
        </p>
    </fieldset>
    <p>
        <%=Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
        <%=Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

