using Microsoft.AspNetCore.SignalR;
using RazorPagesApp.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using MesDixnich.Pages;

public class ChatHub : Hub
{
    public async Task Send(string message, string userName)
    {
        await Clients.All.SendAsync("Receive", message, userName);
    }
}