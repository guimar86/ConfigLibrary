<h1>Gateway Error Library</h1>
<p>This is a library that compiles all errors that come from Gateway and T24 and displays a user friendly message</p>

<h2>Installation</h2>
<p>In order to get the library up and running follow these steps:</p>
<ol>
<li>Clone the project from Bitbucket https://tools.standardbank.co.za/bitbucket/projects/AOSB/repos/core-error-lib/browse</li>
<li>Add the library project to your project:
	<ul>
		<li>Right click your project and select Add > Project Reference </li>
	<ul>
</li>
</ol>

<h2>Usage</h2>

<h3>Startup</h3>
<p> In the startup class add the service AddGatewayErrorCheck to the IServiceCollection </p>

<h3>In classes</h3>
<p>Use the interface IGatewayErrorCheck </p>
<p> It has the following methods</p>

<ul>
	<li>List<Error> ListErrors()</li>
	<li>Error Find(string errorId)</li>
</ul>


