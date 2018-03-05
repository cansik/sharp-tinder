# Sharp Tinder
Sharp Tinder is a basic client framework for the very popular tinder dating app.

The API still works (**March 2018**) but it could be changed by tinder.

## API
Currently supported are following api methods:

* Login - *login to tinder*
* GetUpdates - *get chat updates*
* GetRecommendations - *get new recommendations*
* Rate - *rate a user*
	* Superlike
	* Like
	* Pass
* SendMessage - *send a message to a user*
* GetUser - *get all information about a user*
* UpdatePosition - *update your own position*


## Examples
### Login
The login works over oauth and the new facebook graph api 2.6. So it is a bit tricky in the beginning.

1. You have to get your [facebook user id](http://findmyfbid.com/)!
2. Follow this [link](https://www.facebook.com/v2.6/dialog/oauth?redirect_uri=fb464891386855067%3A%2F%2Fauthorize%2F&state=%7B%22challenge%22%3A%22q1WMwhvSfbWHvd8xz5PT6lk6eoA%253D%22%2C%220_auth_logger_id%22%3A%2254783C22-558A-4E54-A1EE-BB9E357CC11F%22%2C%22com.facebook.sdk_client_state%22%3Atrue%2C%223_method%22%3A%22sfvc_auth%22%7D&scope=user_birthday%2Cuser_photos%2Cuser_education_history%2Cemail%2Cuser_relationship_details%2Cuser_friends%2Cuser_work_history%2Cuser_likes&response_type=token%2Csigned_request&default_audience=friends&return_scopes=true&auth_type=rerequest&client_id=464891386855067&ret=login&sdk=ios&logger_id=54783C22-558A-4E54-A1EE-BB9E357CC11F#_=_) and check the network traffic. After connecting tinder with your account, there should be a message response (from https://www.facebook.com/v2.6/dialog/oauth/confirm?dpr=2), which contains the access token!

```
...&access_token=EAAGm0PX4ZCpsBAD449veptM...
```

Then it is easy, just use the fbid and access token with this method:

```csharp
client.Login(userId, accessToken);
```

### Updates
To get new chat updates simply call this method:

```csharp
var res = await client.GetUpdates(new DateTime(2000, 01, 01));

foreach (var m in res.Matches)
	if (m.Person != null)
		Console.WriteLine($"{m.Person.Name} ({m.Id}) - {2016 - m.Person.BirthDate.Year}");
```

## About
Sharp Tinder was just a proof of concept written in August 2016
