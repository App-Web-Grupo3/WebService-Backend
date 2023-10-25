﻿using Data.Context;
using Data.Model;
using Data.Persistencia.Impl;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistencia;

public class RepresentanteData: IRepresentanteData
{
    private readonly AppDbContext _appDbContext;
    
    public RepresentanteData( AppDbContext appDbContext) 
    {
        _appDbContext = appDbContext;
    }
    
    public async Task<IEnumerable<Representante>> ListAsync()
    {
        return await _appDbContext.Representantes.ToListAsync();
    }

    public async Task AddAsync(Representante representante)
    {
        
        _appDbContext.Representantes.AddAsync(representante);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<Representante> FindByIdAsync(int id)
    {
        return await _appDbContext.Representantes.FindAsync(id);
    }

    public void Update(Representante representante)
    {
        _appDbContext.Representantes.Update(representante);
        _appDbContext.SaveChangesAsync();
    }

    public void Remove(Representante representante)
    {
        _appDbContext.Representantes.Remove(representante);
        _appDbContext.SaveChangesAsync();
    }
}