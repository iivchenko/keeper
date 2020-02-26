#addin Cake.Docker&version=0.10.0
#tool nuget:?package=NUnit.ConsoleRunner&version=3.10.0
var target = Argument("target", "build-objectives");

Setup(context =>
{
	context.Environment.WorkingDirectory = context.Environment.WorkingDirectory + "\\..\\src";
});

Task("build-objectives")
    .Does(() =>
{
	DockerComposeBuild("objective.api");
});

Task("start-objectives")
    .Does(() =>
{
	var settings = new DockerComposeUpSettings { DetachedMode = true };
	DockerComposeUp(settings, "objective.api");
});

Task("run-objectives")
	.IsDependentOn("build-objectives")
	.IsDependentOn("start-objectives")
    .Does(() => { });
	
Task("build-webspa-server")
    .Does(() =>
{
	DockerComposeBuild("webspa.server");
});

Task("start-webspa-server")
    .Does(() =>
{
	var settings = new DockerComposeUpSettings { DetachedMode = true };
	DockerComposeUp(settings, "webspa.server");
});

Task("run-webspa-server")
	.IsDependentOn("build-webspa-server")
	.IsDependentOn("start-webspa-server")
    .Does(() => { });
	
Task("run-all")
	.Does(() => 
{
	var settings = new DockerComposeUpSettings { DetachedMode = true };
	DockerComposeUp(settings, new [] { "objective.api", "webspa.server" });
});

RunTarget(target);