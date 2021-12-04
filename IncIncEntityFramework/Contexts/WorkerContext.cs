//WorkerzContext.cs
//Author: Shweta Patel [Reference: Kyle chapman]
//created: November 20
//Description: A context describing the data in HourlyWorker payroll
//system used to enable the system

using Microsoft.EntityFrameworkCore;
using IncIncEntityFramework.Models;

namespace IncIncEntityFramework.Contexts
{
    public class WorkerContext: DbContext
    {
        /// <summary>
        /// Context Constructor: Use completely default option from the base class.
        /// </summary>
        /// <param name="options"></param>
        public WorkerContext(DbContextOptions<WorkerContext> options) : base(options)
        {

        }
        /// <summary>
        /// Only one set in this database! Refers to the HourlyWorker Model.
        /// </summary>
        public DbSet<PieceWorkerModel> Workers { get; set; }
    }
}
