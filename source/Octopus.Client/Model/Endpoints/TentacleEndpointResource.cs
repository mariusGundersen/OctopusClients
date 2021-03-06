using System;
using System.ComponentModel.DataAnnotations;

namespace Octopus.Client.Model.Endpoints
{
    public abstract class TentacleEndpointResource : EndpointResource
    {
        [Required(ErrorMessage = "Please provide a thumbprint for this machine.")]
        [Trim]
        [Writeable]
        public string Thumbprint { get; set; }

        [Writeable]
        public TentacleDetailsResource TentacleVersionDetails { get; set; }
    }
}