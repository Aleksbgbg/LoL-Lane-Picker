﻿namespace AutoPick.Services.Interfaces
{
    using AutoPick.Models;

    public interface IChampionLoader
    {
        Champion[] LoadAllChampions();
    }
}