# LiveCash

It is course project of user interface for Credit Company database.

The subject area of the term project is a company that provides loans (microcredits). The company's main task is to earn profit by issuing loans with interest. 
The interest rate is calculated individually for each client based on their credit history, initial interest rate, and loan term. To calculate these parameters, 
managers must have data on the client's past transactions with the bank, coefficients for interest rates, 
and the current initial interest rate. 

Additionally, the database should store clients' passport, registration, and contact information, which the collection department will use to collect the necessary 
information in the event of loan default by the client. 

To monitor the company's operations, the director should have a table with information about employees and the turnover of funds (the volume of issued and received funds).

Tasks' use-case diagram:
![use-case diagram](https://i.imgur.com/3cpGJeK.png)

ER-model was created using this use-case diagram: 
![use-case diagram](https://i.imgur.com/K1KNsOn.png)
<br><br><br><br>
Then for this db was developed user interface.

<pre>foreach(user in users)
{
   user.ownInterface  
} 
// Just kidding.</pre><br>

Each user has his own interface based use-case diagram.
