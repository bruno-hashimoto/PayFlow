﻿
namespace Domain.Auth;

public class TokenBody
{
	public string? Token { get; set; }
    public string? Type { get; set; }
    public DateTime Created { get; set; }
}

