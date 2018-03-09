using System;
using System.Collections.Generic;

namespace Iteragram.Models.Responses
{
    public class UsersResponse : Response, IPagination<User>
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public List<User> Data { get; set; }

        /// <summary>
        /// Gets or sets the pagination.
        /// </summary>
        /// <value>
        /// The pagination.
        /// </value>
        public Pagination Pagination { get; set; }
    }
}
