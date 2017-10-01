



C# Lesson 33 Discussion Questions
Chapter 21, pages 469 – 492 

1. What is the difference in the purposes of SQL and LINQ? In other words, why do we need two different query languages? Does LINQ replace SQL? Does SQL make LINQ unnecessary? 
SQL is used to query and manage data in a relational database, where LINQ is used to query in-memory data.  LINQ does not replace SQL nor does SQL make LINQ unnecessary.  Because again, LINQ is used in C# to query in-memory data not relational databases.
2. What is the one essential requirement for the data structures used with LNQ? Why is this requirement important?
The essential requirement for the data structures are they must implement the IEnumerable or IEnumberable<T> interface.  This requirement is important because the LINQ operates over collections.
 3. Where does the LINQ Select() method live?
The LINQ Select Method lives in the Enumberable Class of the System.LINQ namespace.  It is not an Array Method.
 4. (Select) Explain, token by token, each token in this line of code: IEnumerable customerFirstNames = customers.Select(cust => cust.FirstName);
This is a an implementation of the Select Method over an  new collection called customerFirstNames. The Query returns the variable “cust” which is short for “customers” within the lambda expression of the Select Method.  The result the query  will be the customers FirstName.

 5. (Filter) Explain, token by token, each token in this line of code: IEnumerable usCompanies = addresses.Where(addr => String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);
This is an implementation of a filter using the Where Method applied to a new collection called “usCompanies”.  The Where Method returns a variable called “addr” which is the alias for addresses.  The addresses are filtered to include all addresses of usCompanies in the United States.  Within the Select Method a variable is returned called “usComp” which is an alias for companies within the US.
The result for this query will be all companies with an address in the united states. However, this query does not account for duplicates and duplicates will be included in this query.
 6. (OrderBy) Explain, token by token, each token in this line of code: IEnumerable companyNames = addresses.OrderBy(addr => addr.CompanyName).Select(comp => comp.CompanyName);
This is an implementation of the OrderBy Method over a new collection called “companyNames”. The query orders the query results by address based on the variable “addr” which is passed to the Orderby Method which is an alias for “addresses”.  The Select method returns a variable called “comp” with is an alias for CompanyName.  
This query returns a list of companies ordered by address in alphabetical order. Again, this query does not account for duplicates and duplicates may be present.
 7. (Group) Explain, token by token, each token in this line of code: var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);
This is and implementation of the GroupBy Method over a new collection called “companiesGroupedByCountry”.  The GroupBy method returns a variable called “addrs” which is an alias for “addresses” .
The query returns a list of companies grouped by the Country address.  This query will not account for duplicates and duplicates may be present.
 8. (Distinct) Explain, token by token, each token in this line of code: int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();
This is an implementation of the Distinct Method over a new collection called “numberOfCountries”.
The Select Method returns a variable called “addr” which is an alias for “addresses” and filters them using the Distinct Method to remove any duplicate entries.  It then implements the Summary Method “Count” to return the number of companies with addresses in the specific countries.
The query will return the number of companies for each country.
No duplicates will be present in this query.
 9. (Join) Explain, token by token, each token in this line of code: var companiesAndCustomers = customers.Select(c => new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs => custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) => new {custs.FirstName, custs.LastName, addrs.Country }); 

This is an implementation of the Join Method to join the collection Customers with the collection CompanyName using FirstName, LastName and CompanyName as the common attributes in both collections.  The Select Method returns a variable “c” which is the alias for “Customers” and creates a new collection using the alias to prefix FirstName, LastName and CompanyName.  This is then joined using the Join Method to the collection CompanyName that creates a new collection using the alias’s “cust and addrs” to prefix FirstName, LastName and Country of the CompanyName collection. 

10. Explain the difference between a deferred collection and a static, cached collection
The difference between the deferred collection and static, cached collection is that
The deferred evaluation will reflect any changes that were made between the declaration the query and the iteration of the query.  Where with that static cached ToList and ToArry collections, the updates are not displayed because when the parameters of the query are declared, a cache of the original data is created, so the changes to not affect the copy.
