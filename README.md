# Redis HTML Cache for ASP.NET Core 1.0
This repository contains example implementation of HTML Cache using Redis for ASP.NET Core 1.0 MVC.

Usage:
Register CacheService implementation (both Redis and In-memory implementations provided),
add CacheMiddleware into request pipeline and add *Cache* attribute to any method.
```
[Cache(Duration = 30)]
public IActionResult Index()
{
    return View();
}
```

For more information and in-detail description, visit my blog : [http://zablo.net/blog/post/asp-net-core-redis-html-cache](http://bit.ly/redis-asp-net-core-github)
