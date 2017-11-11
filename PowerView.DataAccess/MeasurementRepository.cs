using MongoDB.Bson;
using MongoRepository;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.DataAccess
{
    public class MeasurementRepository: MongoRepository<Measurement>, IMeasurementRepository
    {
       
    }    
}
