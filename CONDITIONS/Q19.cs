/*
Create an OrderStatus enum:
Pending
Processing
Shipped
Delivered
Cancelled
*/
using System;
namespace CONDITIONS;

enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}

public class Q19
{
    public static void Main (string[] args)
    {
        Console.Write("Enter an Order status=");
        string status = Console.ReadLine();
        OrderStatus order = Enum.Parse<OrderStatus>(status);
        string s = order switch
        {
            OrderStatus.Cancelled => "Status is cancelled",
            OrderStatus.Pending => "Status is Pending",
            OrderStatus.Processing => "Status is Processing",
            OrderStatus.Shipped => "Status is Shipped",
            OrderStatus.Delivered => "Status is Delivered",
            _ => "Please enter a valid status"
        };
        Console.WriteLine(s);
    }
}