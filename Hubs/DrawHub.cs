using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalrChat.Hubs{
    public class DrawDotHub: Hub {

        // private int r = new Random((int)DateTime.Now.Ticks).Next(0,255);
        // private int g = new Random((int)DateTime.Now.Ticks).Next(0,255);
        // private int b = new Random((int)DateTime.Now.Ticks).Next(0,255);
        public async Task UpdateCanvas(int x, int y, int r, int g, int b) {
            await Clients.All.SendAsync("updateDot",x, y, r, g, b);
        }

        public async Task ClearCanvas() {
            await Clients.All.SendAsync("clearCanvas");
        }
    }
}