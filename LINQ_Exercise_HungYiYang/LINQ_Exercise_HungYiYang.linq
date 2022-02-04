<Query Kind="Expression">
  <Connection>
    <ID>9f2e78aa-bd85-4e50-9ac8-0003519cbcf2</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>(local)</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

//Hung Yi Yang
//Lab1

//Q1
from Product in Products
orderby Product.OrderLists.Count() descending
select new {
	ProductID = Product.Description,
	TimesPurchased = Product.OrderLists.Count()
}










