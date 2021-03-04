# NetConstruct Assessment
Here is my MVC Assessment for NetConstruct.
Once downloaded or cloned, work can be run in Visual Studio

## Reason for not using a JavaScript Framework/SPA
When building a single page application, the structure of the project would be different from what was required by the assessment.
I would have created two separate projects:

* Client - SPA with JavaScript/TypeScript framework (Angular, React)
* Server - ASP .Net Core 5 Web API

Demonstrated best by the diagram below.
<br>
<img src="https://www.dotnetcurry.com/images/aspnet-core/aspnet-core3-spa/aspnet-core-spa-project.png?w=980&h=556" alt="drawing" width="500"/>

The client SPA would make requests to controllers in the .Net Core API returning JSON to populate the template views of the client. I understand that the assessment was a test of ability to create a .NET MVC application, but I have no prior expirience in returning JavaScript framework generated views from .NET MVC Controllers. 

## Tasks Completed

Task 1 - &#x2611;
<br>
Task 2 - &#x2611;  
Task 3 - &#x2611;
<br>
Task 4 - &#9746; - Almost Completed
* I attempted to implement an additional feature of infinite replies (Reply to comment, Reply to a reply, etc...) 
* In doing so ran into a dead-end with my implementation without enough time to refactor before submission of the assesment was due.
* Happy to explain a potential solution that I believe would work in the interview.

## If More Time was available
* I would have liked to use less css framework, but it enabled me to rapidly style the site.
* I would have implemented unit testing and integration testing as they are very important in software development providing certainty that code works as expected and highlights issues that may not have been thought of in development.
  * I would have adopted a test driven development aproach (TDD), but felt that with the time available it was more important to complete the tasks. 

## Thank you for taking your time to consider me for the position
Regards, Ben

