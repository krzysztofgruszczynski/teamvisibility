using Atlassian.Jira;

const string uri = "https://spatrykk.atlassian.net";
const string userName = "krzysztof.namespace@gmail.com";
const string apiKey = "ATATT3xFfGF0inMgszVSl8RFfV1Rx0UubM_E5ivvQGliP-tGE6xGQ5CrmsU4qmPEuP2Ze-Qnf0YdNruVmRUf-9G8P26KxMyZsFf2WGKdNabU6SqUCecSGAkR6J626sq-YkzzWsRsJSqBA8Vtxj0lHLRiahN1yedOjCP0VO41OkGnTGKeqW3U26c=5DE061EC";
const string projectKey = "DEL";

var jira = Jira.CreateRestClient(uri, userName, apiKey);

/*
// Updste ticket
var issue = await jira.Issues.GetIssueAsync("DEL-3");
issue.Summary = "Updated Summary XYZ";

await issue.SaveChangesAsync();
*/


var issues = from i in jira.Issues.Queryable
             where i.Project == "DEL"
             orderby i.Created
             select i;


var issue = issues.FirstOrDefault();

var projects = await jira.Projects.GetProjectsAsync();
var projectsCount = projects.Count();

Console.WriteLine(issue.Summary + " " + issue.Created.ToString());
