using System;

namespace Octopus.Client.Model
{
    /// <summary>
    /// Properties with this attribute will be persisted to the server when sent using a POST or PUT request.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class WriteableAttribute : ApiPropertyAttribute
    {
    }
}