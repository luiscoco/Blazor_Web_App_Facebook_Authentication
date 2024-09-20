# How to login with Facebook from a Blazor application

1. Enter in this URL: https://developers.facebook.com/

2. Navigate to the menu option: Get Started

![image](https://github.com/user-attachments/assets/a9f709ed-da33-4ca0-8242-44c08a888157)

3. See the Register option is selected then press “Continuar” button
 
![image](https://github.com/user-attachments/assets/d6330642-49a0-4419-a240-81732cda0140)

4. Select the CheckBox and press the button to Confirm your email

![image](https://github.com/user-attachments/assets/ead4aa2f-c8b0-4ffe-af18-f0a3adf3f8d3)

5. Select the Developer option and press the button to continue
 
![image](https://github.com/user-attachments/assets/dbd8d9f1-5bbc-46c7-8ad9-f48745726235)

6. Then you are redirected to this web page: https://developers.facebook.com/apps/

We press the “Crear App” buton

![image](https://github.com/user-attachments/assets/d6eadeb7-0578-4464-91ee-59f0f3059e06)
 
7. Read the folllowing message.

![image](https://github.com/user-attachments/assets/4bbfb162-5c0c-421a-8035-8591436f4191)
 
There is a new way to create apps with Meta

Instead of picking and choosing an option from a list of permissions and products, we create customizable use cases.

Explore use cases

Use cases are made up of the combinations of permissions, roles, and products that developers most frequently use to add integrations and functionality to apps.

Are you looking for something else?

There are a limited number of use cases available right now, but we will add more in the future.

To create an app with something that is not included in our use cases, select "Other" and choose the app type.

8. What commercial portfolio do you want to connect to this app?

Connect a verified business portfolio to your app to access business and third-party user data from other business portfolios and publish this app. You can connect an unverified business portfolio or add one 

later, but you will need to complete verification to access the data.

![image](https://github.com/user-attachments/assets/9e3ac541-faf4-4cd9-a28f-e35976dab4eb)
 
9. We select the second use case: Facebook Login Use Case

https://developers.facebook.com/docs/development/create-an-app/facebook-login-use-case/

Authenticate and prompt users with Facebook login. Our most common use case. 

A secure and fast way for users to sign in to your app or game and have the app ask them for permissions to access their data to personalize their experience. Learn more.

![image](https://github.com/user-attachments/assets/f161754d-6634-4ecf-848b-701993200e80)

10. We enter the application name and we press the next button

![image](https://github.com/user-attachments/assets/78d12570-4fc4-4a02-8a49-f665edad7a08)
 
See the Blazor Web App with Identity we created before

![image](https://github.com/user-attachments/assets/df480cee-d02c-4555-aaa6-4b2d2dabcfd8)

11. Press the Create App button for finishing the process of application creation.

![image](https://github.com/user-attachments/assets/b243bffd-ee24-40af-9de8-9ab9076325ad)
 
12.Enter your password and press the send button

![image](https://github.com/user-attachments/assets/c04426f6-cce8-434e-b49b-481152ae0826)

13. Now you are redirected to the Dashboard

![image](https://github.com/user-attachments/assets/e9845ecf-7b7d-45bd-ab4b-ca71365833dd)

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

![image](https://github.com/user-attachments/assets/2a6e6182-cb7e-478a-afd3-436f41ab3c6e)

15. Press the button “Agregar” in the email section

![image](https://github.com/user-attachments/assets/f119fde1-55d3-4cbd-a3dc-b975f57d11be)

16. See the result

![image](https://github.com/user-attachments/assets/f7342f8c-9276-4101-8723-ff477b1fcc95)

17. We select Configuration in the Menu

Input the Application route in the valid OAuth 

![image](https://github.com/user-attachments/assets/39523ba4-892d-4767-82a5-da8799882ecf)

URI de redireccionamiento de OAuth válidos

El parámetro "redirect_uri" especificado manualmente que se usa con el inicio de sesión en la web debe coincidir exactamente con uno de los URI de esta lista.

El SDK para JavaScript también usa esta lista para los navegadores de la app que bloquean las ventajas emergentes.

![image](https://github.com/user-attachments/assets/f3e2eee4-0846-4f93-841b-fdc63a2152a4)

![image](https://github.com/user-attachments/assets/1435b445-c25a-4dcd-9da5-759467ae9f00)

18. Press Save changes

![image](https://github.com/user-attachments/assets/b23b42f9-8a9a-4673-9308-8e078ee721c7)

 19. Select Panel->Configuración de la app->Básica

![image](https://github.com/user-attachments/assets/0c4aedbd-9d9a-41a4-b8db-86b363dcd00f)

20. Copy these values Identificador de la app y Clave secreta de la app

![image](https://github.com/user-attachments/assets/32b99d38-9a9c-4864-bfe7-63d0d1ac17de)

Identificador de la app: XXXXXXXXXXXXXXX

Clave secreta de la app: XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

21. Open the Blazor aaplication and load the Nuget packages for using the Facebook authenticacion:

Microsoft.AspNetCore.Authentication.Facebook

![image](https://github.com/user-attachments/assets/f24dac67-502c-4ae7-bad1-a664e0b59a01)

![image](https://github.com/user-attachments/assets/9bd7b2eb-9cc1-48ca-914b-14617bb1ecd7)

22. We confirm the Facebook authentication package is loaded in the Dependencies folder

![image](https://github.com/user-attachments/assets/3a8b0164-e208-4096-a00c-6b7f2e75cd95)

23. Open the middleware(program.cs) and add the following code:

```csharp
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
```

NOTA:  Before running the Blazor Web App execute the following command creating the Identity database in SQL Server:

```
docker run ^  -e "ACCEPT_EULA=Y" ^  -e "MSSQL_SA_PASSWORD=Luiscoco123456" ^  -p 1433:1433 ^  -d mcr.microsoft.com/mssql/server:2022-latest
```

In SSMS create the database with the following query:

```
CREATE DATABASE [aspnet-LeccionAuthentication-786afbd3-4fd2-48bc-870d-29133ccc59c8];
GO
```

Modify the connection string in the blazor app:

```
"ConnectionStrings": {"DefaultConnection": "Server=localhost,1433;Database=aspnet-LeccionAuthentication-786afbd3-4fd2-48bc-870d-29133ccc59c8;User Id=sa;Password=Luiscoco123456;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True"}
```

Execute the migration with the following command in Visual Studio Packa Manager: Update-Database

24. Now we run the application and we see the Facebook button for accessing and login in the application

![image](https://github.com/user-attachments/assets/0118085e-1d78-4d51-98fd-feb9d7293e95)

![image](https://github.com/user-attachments/assets/41f930af-4552-4445-a071-e47db55d5aac)

25. We press the Facebook button in the Register page and we are redirected to the following page. 

![image](https://github.com/user-attachments/assets/697c31e2-b7ec-4ee8-92e2-3e9085a801bd)

26. Press the link: Edit Access for confirming the email for accessing the application.

![image](https://github.com/user-attachments/assets/562087e9-ccad-4917-ab55-162f5849ab72)

27. Press the Register button for creating a new user.

![image](https://github.com/user-attachments/assets/82bc20a0-ad97-4fa6-8dab-b16b2502bffd)

28. Press the hyperlink: Click here to confirm your account

![image](https://github.com/user-attachments/assets/be0838a8-218f-44c1-8965-4f942d1c3b25)

29. Once you confirmed the account we receive the following message

![image](https://github.com/user-attachments/assets/aaa318aa-0f7a-4ee0-8040-7b0823e32797)

30. Now we are going to Login with the Facebook button

![image](https://github.com/user-attachments/assets/cd8dc148-e083-4635-b0c3-294d2aa7012a)

31. Now we press the button “Continuar como Luis”

![image](https://github.com/user-attachments/assets/9799a853-4a5a-4469-83ca-bbf5cccbdbb1)

32. Perfect! We are logged with the Facebook Authentication

![image](https://github.com/user-attachments/assets/2c9c81ac-f5e4-4ccd-bcc3-d0e676a18ae3)

33. Now if we navigate to the logged user menú option we can verify one of the External logins is Facebook

![image](https://github.com/user-attachments/assets/63e21278-1a66-4823-9da2-1d2eff271fe9)
