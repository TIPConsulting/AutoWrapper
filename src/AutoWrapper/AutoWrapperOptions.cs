﻿using AutoWrapper.Base;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AutoWrapper
{
    public class AutoWrapperOptions : OptionBase
    {
        public bool UseCustomSchema { get; set; } = false;
        public ReferenceLoopHandling ReferenceLoopHandling { get; set; } = ReferenceLoopHandling.Ignore;
        public bool UseCustomExceptionFormat { get; set; } = false;
        public bool UseApiProblemDetailsException { get; set; } = false;
        public bool LogRequestDataOnException { get; set; } = true;
        public bool IgnoreWrapForOkRequests { get; set; } = false;
        public bool ShouldLogRequestData { get; set; } = true;

        public string SwaggerPath { get; set; } = "/swagger";

        public IEnumerable<AutoWrapperExcludePaths>  ExcludePaths { get; set; } = null;
    }
}
