﻿using Application.DTOs.Request;
using Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IAuthenticateService
    {
        public Task<TokenDTO> Authenticate(LoginDTO loginDTO);
    }
}
