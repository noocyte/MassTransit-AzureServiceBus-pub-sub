﻿using System;
using System.Threading.Tasks;
using MassTransit;
using MassTransitDemo.Messaging.Contract.Commands;

namespace MassTransitDemo.Registration.Service
{
    internal class RegisterOrderConsumer : IConsumer<MyOrder>
    {
        public async Task Consume(ConsumeContext<MyOrder> context)
        {
            await Console.Out.WriteLineAsync($"Order with id {context.Message.Id} " +
                                             $"Content : {context.Message.Content} has been registered");

        }
    }
}