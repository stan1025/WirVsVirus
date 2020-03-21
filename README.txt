Deployment Steps:

- From ElasticBeanstalk console, use the "Create New Environment" wizard to create a "Web Server Environment" and select platform as "IIS".

- Follow the wizard instructions on every step, in the "Additional Resources" step, select "Create an RDS DB Instance with this environment"

- In "RDS Configuration" step, change "DB engine" to "sqlserver-ex" and increase the "Allocated storage" to 20 GB.

- After environment created successfully, open BeanstalkDotNetSample solution in visual.

- Right click on the solution name from the "Solution Explorer" and click "Publish to AWS" then follow the instructions, this requires AWS SDK for .NET to be installed.
