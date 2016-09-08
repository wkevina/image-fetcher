using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageFetcher;

class Program
{

    private static string[] URLS = {
        "http://static.adzerk.net/Advertisers/6768ddb6a63e482c9c31155cdde7af9a.png",
        "http://engine.adzerk.net/i.gif?e=eyJhdiI6NDE0LCJhdCI6NCwiYnQiOjAsImNtIjo0NzE0OTMsImNoIjoxMTc4LCJjayI6e30sImNyIjoxNjI3NzYzLCJkaSI6IjE1MTIyMmU3N2M5OTQ2ZTliMDk5YTI3NGM0YWJkMzQ0IiwiZG0iOjEsImZjIjoxOTI0NDQyLCJmbCI6MjE0MjMxMiwiaXAiOiI1MC43OC40My4yNSIsImt3IjoiYyMsbGlzdCxmb3ItbG9vcCIsIm53IjoyMiwicGMiOjAsImVjIjowLCJwciI6MTYwNCwicnQiOjEsInJmIjoiaHR0cHM6Ly93d3cuZ29vZ2xlLmNvbS8iLCJzdCI6ODI3NywidWsiOiJ1ZTEtOWMxM2ZmZTQ2OTVhNGVkNmJlYjA2MWZiN2ZlYmI4MzgiLCJ6biI6NDMsInRzIjoxNDczMjg2ODk0Mzg5LCJiZiI6dHJ1ZSwicG4iOiJjbGMtdGxiIiwiZnEiOjB9&s=jth68OD7Evx9MoTTqab9hrVh1mU",
        "https://www.gravatar.com/avatar/25a22103fd3210fdfa142843c7777ff1?s=32&d=identicon&r=PG",
        "https://www.gravatar.com/avatar/91185ef26d947f42af17aab5ec778270?s=32&d=identicon&r=PG",
        "https://www.gravatar.com/avatar/55997cec217233703cbf68b689578771?s=32&d=identicon&r=PG",
        "http://static.adzerk.net/Advertisers/d220101fccb24c5f805ac8f614335fc7.png",
        "http://engine.adzerk.net/i.gif?e=eyJhdiI6NDE0LCJhdCI6NCwiYnQiOjAsImNtIjo0NzE0OTMsImNoIjoxMTc4LCJjayI6e30sImNyIjoxNjI3NzY3LCJkaSI6IjdkOWQ5OTAyMmYzMzQzMzFhZjkyNjQzNmNlOGNkOWUxIiwiZG0iOjEsImZjIjoxOTI0NDQ2LCJmbCI6MjE0MjMxMiwiaXAiOiI1MC43OC40My4yNSIsImt3IjoiYyMsbGlzdCxmb3ItbG9vcCIsIm53IjoyMiwicGMiOjAsImVjIjowLCJwciI6MTYwNCwicnQiOjEsInJmIjoiaHR0cHM6Ly93d3cuZ29vZ2xlLmNvbS8iLCJzdCI6ODI3NywidWsiOiJ1ZTEtOWMxM2ZmZTQ2OTVhNGVkNmJlYjA2MWZiN2ZlYmI4MzgiLCJ6biI6NDQsInRzIjoxNDczMjg2ODk0MzkxLCJiZiI6dHJ1ZSwicG4iOiJjbGMtbWxiIiwiZnEiOjB9&s=F599sTQJTCiADoBkJM0tM4sqWvc",
        "https://i.stack.imgur.com/ITEsv.png?s=32&g=1",
        "https://www.gravatar.com/avatar/72c7a1f2ada7603776cb05fd2ca33937?s=32&d=identicon&r=PG",
        "https://www.gravatar.com/avatar/5a651b0c7247fbf3e7ce11b7b2b462d7?s=32&d=identicon&r=PG",
        "https://www.gravatar.com/avatar/549acdbbe6ac79e0684543945d83fcfb?s=32&d=identicon&r=PG",
        "https://www.gravatar.com/avatar/aa671942271b5e25f79da4c544cd8c7e?s=32&d=identicon&r=PG",
        "https://i.stack.imgur.com/YL96W.jpg?s=32&g=1",
        "https://www.gravatar.com/avatar/e93a372e263490e0cf273ede0a1393ed?s=32&d=identicon&r=PG",
        "https://www.gravatar.com/avatar/7ed6a2c2b5894c744c66710fbfadc648?s=32&d=identicon&r=PG",
        "https://i.stack.imgur.com/Hi5gw.jpg?s=32&g=1",
        "https://www.gravatar.com/avatar/26483382e3717e58e4c45d06c8ec351d?s=32&d=identicon&r=PG",
        "http://clc.stackoverflow.com/soi.gif?an=Y2Ni4GpnDM69ftmDAQRYGRnUXjKxcjAwMrAzAfksp2KYGTImvq2xN31lzwoWZ0wBEixgST0gwQ9ibUtlZljkuu3z3ysP7JnRVLnGMTNcX1xgy3X9tT0LRI4BJMcPMgGkwCCbmeH575UfL_k-w9DMYM6WWMJrNdn68gIA&at=0&pt=375"
    };

    static void Main(string[] args)
    {
        new ResourceFetcher(URLS, ".");
    }
}

