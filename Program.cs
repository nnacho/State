
//State
abstract class PlayerState
{
    public abstract void _IdleState();
    public abstract void _WalkState();
    public abstract void _RunState();
    public abstract void _AttackState();
    public abstract void _DeathState();
}

//Context
class Player
{
    PlayerState state;
    PlayerState idleState;
    PlayerState walkState;
    PlayerState runState;
    PlayerState attackState;
    PlayerState deathState;

    public Player()
    {
        idleState = new IdleState(this);
        walkState = new WalkState(this);
        runState = new RunState(this);
        attackState = new AttackState(this);
        deathState = new DeathState(this);
        state = idleState;
    }
    public void SetIdle() => state = idleState;
    public void SetWalk() => state = walkState;
    public void SetRun() => state = runState;
    public void SetAttack() => state = attackState;
    public void SetDeath() => state = deathState;

    public void Idle() => state._IdleState();
    public void Walk() => state._WalkState();
    public void Run() => state._RunState();
    public void Attack() => state._AttackState();
    public void Death() => state._DeathState();


    static void Main(string[] args)
    {
        Player player = new Player();

        Console.WriteLine("********");
        player.Walk();
        player.Idle();
        player.Idle();
        player.Walk();
        player.Run();
        player.Run();
        player.Idle();
        player.Walk();
        player.Attack();
        player.Attack();
        player.Death();
        player.Death();
        Console.WriteLine("********");
    }
}

//Concrete State
class IdleState : PlayerState
{
    Player _context;
    public IdleState(Player context) => _context = context;

    public override void _IdleState()
    {
        Console.WriteLine("karakter zaten duruyor!");
    }
    public override void _WalkState()
    {
        Console.WriteLine("karakter yürüyor!");
        _context.SetWalk();
    }
    public override void _RunState()
    {
        Console.WriteLine("karakter koşuyor!");
        _context.SetRun();
    }

    public override void _AttackState()
    {
        Console.WriteLine("karakter saldırıyor!");
        _context.SetAttack();
    }

    public override void _DeathState()
    {
        Console.WriteLine("karakter öldü!");
        _context.SetDeath();
    }
}

//Concrete State
class WalkState : PlayerState
{
    Player _context;

    public WalkState(Player context) => _context = context;

    public override void _IdleState()
    {
        Console.WriteLine("karakter duruyor!");
        _context.SetIdle();
    }
    public override void _WalkState()
    {
        Console.WriteLine("karakter zaten yürüyor!");
    }
    public override void _RunState()
    {
        Console.WriteLine("karakter koşuyor!");
        _context.SetRun();
    }
    public override void _AttackState()
    {
        Console.WriteLine("karakter saldırıyor!");
        _context.SetAttack();
    }
    public override void _DeathState()
    {
        Console.WriteLine("karakter öldü!");
        _context.SetDeath();
    }
}

//Concrete State
class RunState : PlayerState
{
    Player _context;

    public RunState(Player context) => _context = context;
    public override void _IdleState()
    {
        Console.WriteLine("karakter duruyor!");
        _context.SetIdle();
    }
    public override void _WalkState()
    {
        Console.WriteLine("karakter yürüyor!");
        _context.SetWalk();
    }
    public override void _RunState()
    {
        Console.WriteLine("karakter zaten koşuyor!");
    }
    public override void _AttackState()
    {
        Console.WriteLine("karakter saldırıyor!");
        _context.SetAttack();
    }
    public override void _DeathState()
    {
        Console.WriteLine("karakter öldü!");
        _context.SetDeath();
    }
}

//Concrete State
class AttackState : PlayerState
{
    Player _context;
    public AttackState(Player context) => _context = context;
    public override void _IdleState()
    {
        Console.WriteLine("karakter duruyor!");
        _context.SetIdle();
    }
    public override void _WalkState()
    {
        Console.WriteLine("karakter yürüyor!");
        _context.SetWalk();
    }
    public override void _RunState()
    {
        Console.WriteLine("karakter koşuyor!");
        _context.SetRun();
    }
    public override void _AttackState()
    {
        Console.WriteLine("karakter zaten saldırıyor!");
    }
    public override void _DeathState()
    {
        Console.WriteLine("karakter öldü!");
        _context.SetDeath();
    }
}

//Concrete State
class DeathState : PlayerState
{
    Player _context;
    public DeathState(Player context) => _context = context;
    public override void _IdleState()
    {
        Console.WriteLine("karakter duruyor!");
        _context.SetIdle();
    }
    public override void _WalkState()
    {
        Console.WriteLine("karakter yürüyor!");
        _context.SetWalk();
    }
    public override void _RunState()
    {
        Console.WriteLine("karakter koşuyor!");
        _context.SetRun();
    }
    public override void _AttackState()
    {
        Console.WriteLine("karakter saldırıyor!");
        _context.SetAttack();
    }
    public override void _DeathState()
    {
        Console.WriteLine("karakter zaten ölü!");
    }
}