<h1>Azure App Service</h1>
<h2>How to Set ASPNETCORE_ENVIRONMENT</h2>

Setting the ASPNETCORE_ENVIRONMENT variable in an Azure App Service to "Development" enables detailed error information to be shown on a web page when an exception is thrown by your web app. It is recommending that you not do this if for a production web site (visible to real users), since it could be a security risk.

Here are the steps:

1. In Portal.Azure.com, open your Azure App Service and click on "Configuration":  
   ![AzureAppService-Overview](/Users/birdb/Projects/CS295N-CourseMaterials/LectureNotes/Images/AzureAppService-Overview.png)



2. On the Configuration screen, click on "+ New application setting" (in the middle): 
   ![](/Users/birdb/Projects/CS295N-CourseMaterials/LectureNotes/Images/ApplicationSettings.png)



3. Enter the new setting:  
   ![](/Users/birdb/Projects/CS295N-CourseMaterials/LectureNotes/Images/Configuration.png)

   

4. Click on the "Save" button (at the top):

   ![](/Users/birdb/Projects/CS295N-CourseMaterials/LectureNotes/Images/ApplicationSettings-ASPNETCORE_ENVIRONMENT.png)



That's it!

