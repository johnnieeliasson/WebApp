﻿using WebApp.Contexts;

namespace WebApp.Helpers.Repositories;

public class AddressRepository : Repo<AddressEntity>
{
    public AddressRepository(DataContext context) : base(context)
    {
    }
}
