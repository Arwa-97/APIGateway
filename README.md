# API Gateway In Microservices 
This is a simple demo for demonstrating the use of api gateway using ocelot.

Imagine that you are looking for a vehical, its loaction and price. so we have three services (Map, Price and Vehical service)
and the api gateway that will call each service.

for testing the demo this is how to call the endpoints through the gateway:

https://localhost:7189/api/{servicename}
