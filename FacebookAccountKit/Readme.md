# Facebook Account Kit SDK

This project uses sms validation using facebook account kit. <br>
Not suitable for production environment. Remember to check before using the codes.

## Code Example

```csharp
FacebookAccountKitSdk facebookAccountKitSdk = new FacebookAccountKitSdk("MyFacebookAppId", "MyFacebookAccountKitSecretKey");
var token = await facebookAccountKitSdk.GetTokenAsync("MyClientAuthCode");

try 
{
    var userInformation =await facebookAccountKitSdk.GetUserInformationAsync();
}
catch (Error error)
{
    Console.WriteLine(error.Message);
    throw;
}
var isValidationSuccess = facebookAccountKitSdk.ValidateUserAsync("+015551234567");
```

## Installing 

```
-Install-Package Betalgo.FacebookAccountKit 
```

