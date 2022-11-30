using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WorldcupWeb.Data;
using System;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace WorldcupWeb.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WorldcupWebContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<WorldcupWebContext>>()))
        {
            // Look for any movies.
            if (context.WorldCup.Any())
            {
                return;   // DB has been seeded
            }
            context.WorldCup.AddRange(
                new WorldCup
                {
                    Country1 = "Qatar",
                    Score = "0-2",
                    Country2 = "Ecuado"
                },
                new WorldCup
                {
                    Country1 = "Senegal",
                    Score = "0-2",
                    Country2 = "Hà Lan"
                },
                new WorldCup
                {
                    Country1 = "Anh",
                    Score = "6-2",
                    Country2 = "Iran"
                },
                new WorldCup
                {
                    Country1 = "Mỹ",
                    Score = "1-1",
                    Country2 = "Xứ Wales"
                }
            );
            context.SaveChanges();
        }
    }
}