# OfferingSolutions Datashaper Demo Application

## Nuget

http://www.nuget.org/packages/OfferingSolutions.DataShaper/

## Description

Allows your Api to shape your data before sending it to the client. 

![datashaping-picture1](http://fabian-gosebrink.de/img/projects/datashaper_2.PNG)
![datashaping-picture2](http://fabian-gosebrink.de/img/projects/datashaper_3.PNG)
![datashaping-picture3](http://fabian-gosebrink.de/img/projects/datashaper_4.PNG)

I made this demo-solution to show how this stuff works.

Simply start the webapplication and use Fiddler or any tool you want to create http-calls and type things like

<pre>/api/Test?fields=Id,Date</pre>

or

<pre>/api/Test?fields=Id,Date,ChildClasses.Description,ChildClasses.Id</pre>

and you will get the shaped result.
