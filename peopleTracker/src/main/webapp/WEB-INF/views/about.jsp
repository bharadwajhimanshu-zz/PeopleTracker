<!DOCTYPE html>
<html>
<head>
<meta http-equiv="X-UA-Compatible" content="IE=edge" />
<title>About</title>
<link rel="stylesheet" href="contents/bootstrap.css" type="text/css" />
<link rel="stylesheet" href="contents/style.css" type="text/css" />
</head>
<body>

	<div class="navbar navbar-inverse navbar-fixed-top">
		<div class="container">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle" data-toggle="collapse"
					data-target=".navbar-collapse">
					<span class="icon-bar"></span> <span class="icon-bar"></span> <span
						class="icon-bar"></span>
				</button>
				<a class="navbar-brand" href="/peopleTracker">//build/ 2015</a>
			</div>
			<div class="navbar-collapse collapse">
				<ul class="nav navbar-nav">
					<li><a href="/peopleTracker">Home</a></li>
					<li><a href="/peopleTracker/about">About</a></li>
					<li><a href="/peopleTracker/contact">Contact</a></li>
				</ul>
			</div>
		</div>
	</div>
	<div class="container body-content">
		<h2>About</h2>
		<!-- <h3>${message}</h3> -->
		<div class="message" id="messageParagraph"><p>${message}</p></div>
		<p>Use this area to provide additional information.</p>
		<p>aboutURL = ${aboutUrl}</p>
		<p>contactURL = ${contactUrl}</p>
		<hr />
		<footer>
			<p>&copy; 2015 - My Java Application</p>
		</footer>
	</div>
</body>
</html>
