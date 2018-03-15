# BUILD A PHOTO FEED USING ASP.NET

Here, we will learn about building a photo feed using Django. This is similar to instagram, but a stripped off version without the comments and like feature. The full tutorial can be found here : [https://pusher.com/tutorials/photo-feed-aspnet/ ](https://pusher.com/tutorials/photo-feed-aspnet/) 

## Getting Started

Clone the project repository by running the command below if you use SSH

```
git clone git@github.com:samuelayo/ASP.NET-PHOTO-FEED.git
```

If you use https, use this instead

```
git clone https://github.com/samuelayo/ASP.NET-PHOTO-FEED.git
```

After cloning, open the `pusher_realtime_table.sln` file in visual studio.

### Prerequisites

#### Setup Pusher

If you don't have one already, create a free Pusher account at https://pusher.com/signup then login to your dashboard and create an app. 


Then fill in your Pusher app credentials in your `Controllers\HomeController` file by replacing this line with your appid, appkey and app secret respectively:

```
var pusher = new Pusher("XXX_APP_ID", "XXX_APP_KEY", "XXX_APP_SECRET", options);
```

Also, remember to fill in the your secret key and app cluster in your `Views\Home\view.cshtml` file by updating this line:

```
var pusher = new Pusher('XXX_APP_KEY', {cluster: 'XXX_CLUSTER'});
```

And finally, start the application by clicking the debug button on your visual studio.

## Built With

* [Pusher](https://pusher.com/) - APIs to enable devs building realtime features
* [ASP.NET](https://www.asp.net/) - Open source web framework for building modern web apps and services with .NET. 
* [Jquery](https://jquery.com/) - The Write Less, Do More, JavaScript Library

