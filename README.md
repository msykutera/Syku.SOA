# Syku.SOA
Simple .NET Core website that uses external rest service

It's simple example of how one could utilise SOA in .NET Core projects. 

Solution consists of three projects:
1) Common - contains shared models.
2) Website - serves html pages to users and serves as client for Service.
3) Service - is called using RestSharp library and returns <i>Statistics</i> object, that in real implementation would contain result of large amount of computation, hence it would be moved to service running on external machine.
