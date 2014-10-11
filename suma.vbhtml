@code
Page.title="Sumar"
dim totalMessage = ""
if(IsPost)
    dim num1 = Request("text1")
    dim num2 = Request("text2")
    dim total = num1.AsInt() + num2.AsInt()
    totalMessage = "Total = " & total
End If
End Code
<!DOCTYPE html>
<html>
    <head>
        <title>Suma de dos Numeros</title>
    </head>
<body style="background-color: beige; font-family: Verdana, Arial">
<h1><center>SUMA DE DOS NUMEROS</center></h1>
<form action="" method="post">
<center>
<table>
<tr>
<td>First Number:</td>
<td><input type="text" name="text1"></td>
</tr>
<tr>
<td>Second Number:</td>
<td><input type="text" name="text2"></td>
</tr>
<tr>
<td><input type="submit" value=" Sumar "></td>
</tr>
</table>
</center>

</form>
<p><center>@totalMessage</center></p>

</body>
</html>
