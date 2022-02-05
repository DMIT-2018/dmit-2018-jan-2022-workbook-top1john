<Query Kind="Statements">
  <Connection>
    <ID>9f2e78aa-bd85-4e50-9ac8-0003519cbcf2</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>(local)</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

//Hung Yi Yang
//LINQ Exercise

//Q1
Products
   .OrderByDescending(Product => Product.OrderLists.Count())
   .Select(
	  Product =>
		 new
		 {
			 ProductID = Product.Description,
			 TimesPurchased = Product.OrderLists.Count()
		 }
   ).Dump();


//Q2
Stores
	.OrderBy(e => e.Location)
   .Select(
	  e =>
		 new
		 {
			 Location = e.Location,
			 Clients = e.Orders
			   .Select(
				  c =>
					 new
					 {
					 	address = c.Customer.Address,
						 city = c.Customer.City,
						 province = c.Customer.Province
					 }
			   ).Distinct()
		 }
   ).Dump();








