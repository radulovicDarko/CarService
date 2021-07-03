<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CarServiceWebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron text-center">
        <h1>CAR SERVICE</h1>
    </div>
    <div class="container text-center">
	<div class="row">
		<div class="col-md-3">
		</div>
		<div class="col-md-3">
			<div class="card">
				<h1 class="card-header">
					Car Inspections
				</h1>
				<div class="card-body">
					<asp:button class="btn-block btn-primary btn-lg" runat="server" ID="ButtonCarInspections" Text="OPEN ME"></asp:button>
				</div>
			</div>
		</div>
		<div class="col-md-3">
			<div class="card">
				<h1 class="card-header">
					Clients
				</h1>
				<div class="card-body">
					<asp:button class="btn-block btn-primary btn-lg" runat="server" ID="ButtonClients" Text="OPEN ME"></asp:button>
				</div>
			</div>
		</div>
		<div class="col-md-3">
		</div>
	</div>
</div>
</asp:Content>
