# How to login with Facebook from a Blazor application

1. Enter in this URL: https://developers.facebook.com/

2. Navigate to the menu option: Get Started
 
3. See the Register option is selected then press “Continuar” button
 







4. Select the CheckBox and press the button to Confirm your email
 
5. Select the Developer option and press the button to continue
 









6. Then you are redirected to this web page: https://developers.facebook.com/apps/
We press the “Crear App” buton
 
7. Read the folllowing message.
 
There is a new way to create apps with Meta
Instead of picking and choosing an option from a list of permissions and products, we create customizable use cases.
Explore use cases
Use cases are made up of the combinations of permissions, roles, and products that developers most frequently use to add integrations and functionality to apps.
Are you looking for something else?
There are a limited number of use cases available right now, but we will add more in the future.
To create an app with something that is not included in our use cases, select "Other" and choose the app type.
8. What commercial portfolio do you want to connect to this app?
Connect a verified business portfolio to your app to access business and third-party user data from other business portfolios and publish this app. You can connect an unverified business portfolio or add one later, but you will need to complete verification to access the data.
 
9. We select the second use case: Facebook Login Use Case
https://developers.facebook.com/docs/development/create-an-app/facebook-login-use-case/
Authenticate and prompt users with Facebook login. Our most common use case. A secure and fast way for users to sign in to your app or game and have the app ask them for permissions to access their data to personalize their experience. Learn more.
 

10. We enter the application name and we press the next button
 
See the Blazor Web App with Identity we created before
 
11. Press the Create App button for finishing the process of application creation.
 



12. Enter your password and press the send button
 
13. Now you are redirected to the Dashboard
 


Welcome to the apps panel
Here you will manage all aspects of your app and data access.
In the dashboard, all developers can:
Add use cases to this app
Customize permissions, settings, and other use case options
Test API calls
Additionally, technology providers can:
Complete verification processes
Review and complete data access requirements
Submit the app for review
We're working on more improvements, so stay tuned for future updates.

14. Press the button “Agregar y personalizar casos de uso”
 








15. Press the button “Agregar” in the email section
 



16. See the result
 

17. We select Configuration in the Menu
Input the Application route in the valid OAuth 
 
URI de redireccionamiento de OAuth válidos
El parámetro "redirect_uri" especificado manualmente que se usa con el inicio de sesión en la web debe coincidir exactamente con uno de los URI de esta lista. El SDK para JavaScript también usa esta lista para los navegadores de la app que bloquean las ventajas emergentes.
 
 
18. Press Save changes
 

19. Select Panel->Configuración de la app->Básica
 
20. Copy these values Identificador de la app y Clave secreta de la app
 
Identificador de la app: XXXXXXXXXXXXXXX
Clave secreta de la app: XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
21. Open the Blazor aaplication and load the Nuget packages for using the Facebook authenticacion:
Microsoft.AspNetCore.Authentication.Facebook
 
 
22. We confirm the Facebook authentication package is loaded in the Dependencies folder
 
23. Open the middleware(program.cs) and add the following code: 
builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddFacebook(options=>
    {
        options.AppId = "1688021108430552";
        options.AppSecret = "ea39fce262e71902ef468e5ee6d33aa3"; 
    })
    .AddIdentityCookies();

NOTA:  Before running the Blazor Web App execute the following command creating the Identity database in SQL Server:
docker run ^  -e "ACCEPT_EULA=Y" ^  -e "MSSQL_SA_PASSWORD=Luiscoco123456" ^  -p 1433:1433 ^  -d mcr.microsoft.com/mssql/server:2022-latest


In SSMS create the database with the following query:
CREATE DATABASE [aspnet-LeccionAuthentication-786afbd3-4fd2-48bc-870d-29133ccc59c8];
GO

Modify the connection string in the blazor app:
"ConnectionStrings": {"DefaultConnection": "Server=localhost,1433;Database=aspnet-LeccionAuthentication-786afbd3-4fd2-48bc-870d-29133ccc59c8;User Id=sa;Password=Luiscoco123456;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True"}

Execute the migration with the following command in Visual Studio Packa Manager: Update-Database

24. Now we run the application and we see the Facebook button for accessing and login in the application

 
 
25. We press the Facebook button in the Register page and we are redirected to the following page. 
 
26. Press the link: Edit Access for confirming the email for accessing the application.
 

27. Press the Register button for creating a new user.
 

28. Press the hyperlink: Click here to confirm your account
 






29. Once you confirmed the account we receive the following message 
30. Now we are going to Login with the Facebook button
 




31. Now we press the button “Continuar como Luis”
 

32. Perfect! We are logged with the Facebook Authentication
  

33. Now if we navigate to the logged user menú option we can verify one of the External logins is Facebook
 


