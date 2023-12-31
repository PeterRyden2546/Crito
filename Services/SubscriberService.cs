﻿using Crito.Contexts;
using Crito.Models;

namespace Crito.Services;

public class SubscriberService
{
    private readonly DataContext _context;

    public SubscriberService(DataContext context)
    {
        _context=context;
    }

    public async Task AddSubscriberAsync(NewsletterForm form)
    {
        _context.Subscribers.Add(new SubscribersEntity { Email = form.Email });
        await _context.SaveChangesAsync();
    }
}
