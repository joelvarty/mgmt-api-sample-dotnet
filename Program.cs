
using management.api.sdk;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
						.SetBasePath(AppContext.BaseDirectory)
						.AddJsonFile("appsettings.json");

var config = builder.Build();

var authToken = config["Agility:AuthToken"];
var guid = config["Agility:InstanceGuid"];
var locale = config["Agility:Locale"];

if (string.IsNullOrWhiteSpace(authToken))
{
	Console.WriteLine($"No auth token found. Please authenticate.");
	return;
}

if (string.IsNullOrWhiteSpace(guid) || string.IsNullOrWhiteSpace(locale))
{
	Console.WriteLine($"No guid or locale found in app settings.");
	return;
}

//initialize the Options Class
agility.models.Options options = new agility.models.Options();

options.token = authToken;
options.guid = guid;
options.locale = locale;

//Initialize the Method Class
ContentMethods contentMethods = new ContentMethods(options);

//make the request: get a content item with the ID '109'
var contentItem = await contentMethods.GetContentItem(109);

// See https://aka.ms/new-console-template for more information
if (contentItem == null)
{
	Console.WriteLine($"Could not get content item");
	return;
}

Console.WriteLine($"Got content item.  Version ID: {contentItem.properties.versionID}, title: {contentItem.GetField("title", typeof(string))}");


contentItem.fields["Title"] = "Travel Tipe 2001";
var resp = await contentMethods.SaveContentItem(contentItem);

Console.WriteLine($"Saved content item {resp}");








