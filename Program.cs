
using management.api.sdk;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
						.SetBasePath(AppContext.BaseDirectory)
						.AddJsonFile("appsettings.json");

var config = builder.Build();

var token = config["Agility:AuthToken"];

Console.WriteLine($"Config val AgilityAuthToken");
Console.WriteLine(token);


// //initialize the Options Class
// agility.models.Options options = new agility.models.Options();

// options.token = "<<Provide Auth Token>>";
// options.guid = "<<Provide the Guid of the Website>>";
// options.locale = "<<Provide the locale of the Website>>"; //Example: en-us

// //Initialize the Method Class
// ContentMethods contentMethods = new ContentMethods(options);

// //make the request: get a content item with the ID '22'
// var contentItem = await contentMethods.GetContentItem(22);

// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
