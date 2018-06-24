# Repository-Unit-Of-Work-Pattern-

#Project Title The project is about Unit of work pattern and its implementation for a simple CRUD Application.

#Getting Started with Visual Studio Environment and SSMS

#Prerequisites You need development environment Visual Studio and SQL Infrastructure Environment i.e. SSMS

#Example  1 Unit of work = Modified records in a transaction
          1 User CRUD = 1 unit of work
          3 Users CRUD = 1 Logical unit of work


#Note 
Application (CRUD) => In Memory Collection(Business Object) => Database(1 Trancation/1 go ,results commit or fail)        
