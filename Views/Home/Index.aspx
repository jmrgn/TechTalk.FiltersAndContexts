<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= Html.Encode(ViewData["Message"]) %></h2>
    <p>
        1) First, go over Authorization. Click on "About" as Unauthorized user. Talk about Filter Scope
    </p>
    <p>
        2) Second, go over Action Filters. Show Logging (OnExecuted) 
    </p>
    <p>
        3) Exeption Handling. Cause an <%= Html.ActionLink("Error", "Error", "Home")%>.
    </p>
    <p>
        4) Try it again w/a recoverable error. Cause a <%= Html.ActionLink("Recoverable Error", "RecoverableError", "Home")%>.
    </p>
    <p>
        5) Let's do some <%= Html.ActionLink("Output Caching", "OutputCache", "Home")%> with Result Filtering.
    </p>
    <p>
        6) Let's do a test on  <%= Html.ActionLink("Ordering and Scope", "Index", "Ordering")%>.
    </p>
</asp:Content>
