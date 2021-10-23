using System;

namespace Imago.BusinessCore.DomainModels
{
    public class Candidate : Worker
    {
        public Candidate(Guid id, string forename, string surname, int workforce, Guid userId) : base(id, forename, surname, workforce, userId)
        {
        }
    }
}
