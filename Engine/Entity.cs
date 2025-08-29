namespace Engine;

public class Entity
{
    public SimCore Core { get; init; }
    
    public Entity(SimCore core)
    {
        Core = core;
    }

    public virtual void OnRender(ViewDriver driver)
    {
        
    }
    
    public virtual void TickUpdate()
    {
        
    }

    public virtual void OnCreate()
    {
        
    }

    public virtual void OnRemove()
    {
        
    }
}