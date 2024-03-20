public static void ChangeTrackingEnumeratedObjects(Repository<TestClass> repo)
{
    // Get the DbContext from the repository
    var context = repo.GetContext();

    // Get the ChangeTracker instance
    var changeTracker = context.ChangeTracker;

    // Enumerate the entries that are being tracked by the context
    foreach (var entry in changeTracker.Entries())
    {
        // Get the current entity
        var entity = entry.Entity;

        // Get the current state of the entity
        var state = entry.State;

        // Do something based on the state
        switch (state)
        {
            case EntityState.Added:
                // The entity is new and will be inserted into the database
                Console.WriteLine($"Added: {entity}");
                break;
            case EntityState.Modified:
                // The entity has been modified and will be updated in the database
                Console.WriteLine($"Modified: {entity}");
                break;
            case EntityState.Deleted:
                // The entity has been deleted and will be removed from the database
                Console.WriteLine($"Deleted: {entity}");
                break;
            case EntityState.Unchanged:
                // The entity has not been changed and will not be affected by the database operation
                Console.WriteLine($"Unchanged: {entity}");
                break;
            default:
                // The entity has an unknown state
                Console.WriteLine($"Unknown: {entity}");
                break;
        }
    }
}
