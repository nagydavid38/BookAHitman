<%-- 
    Document   : index
    Created on : 2020.05.15., 23:00:00
    Author     : Dávid
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Continental Price Offer</title>
    </head>
    <body>
        <h1>Search for Hitmen</h1>
        <form action="ContinentalServlet" method="get">
            Style: <input type="text" name="style" /><br/>
            Price: <input type="number" name="price" /><br/>
            <input type="submit" value="submit"/>
        </form>
    </body>
</html>
