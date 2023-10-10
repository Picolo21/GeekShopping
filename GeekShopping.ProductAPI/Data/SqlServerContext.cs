﻿using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Data;

public class SqlServerContext : DbContext
{
    public SqlServerContext() {}

    public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options) { }
}