using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Technical.Test.Data;
using Technical.Test.Entities;

namespace Technical.Test.Controllers;

/// <summary>
/// Controller for managing categories in the application.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class CategoriesController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

    /// <summary>
    /// Retrieves all categories from the database.
    /// </summary>
    /// <returns>
    /// An <see cref="IActionResult"/> containing the list of categories if found; otherwise, a NotFound result.
    /// </returns>
    [HttpGet]
    public async Task<IActionResult> GetCategories()
    {
        var categories = await _context.Categories.ToListAsync();

        if (categories == null)
        {
            return NotFound("No categories found.");
        }

        return Ok(categories);
    }

    /// <summary>
    /// Retrieves a specific category by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the category to retrieve.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> containing the found category if it exists; otherwise, a NotFound result.
    /// </returns>
    [HttpGet("ById")]
    public async Task<IActionResult> GetCategoryById([FromQuery] int id)
    {
        var category = await _context.Categories.FindAsync(id);

        return Ok(category);
    }

    /// <summary>
    /// Creates a new category in the database.
    /// </summary>
    /// <param name="categoryRequest">The category data to create.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> containing the created category if successful; otherwise, a BadRequest result.
    /// </returns>
    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] Category categoryRequest)
    {
        if (categoryRequest is null)
            return BadRequest("Invalid category data.");

        var category = new Category
        {
            Name = categoryRequest.Name,
            Description = categoryRequest.Description
        };

        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();

        return Ok(category);
    }

    /// <summary>
    /// Updates an existing category in the database.
    /// </summary>
    /// <param name="id">The unique identifier of the category to update.</param>
    /// <param name="category">The updated category data.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> indicating the result of the update operation.
    /// Returns <see cref="OkResult"/> if the update is successful; otherwise, <see cref="NotFoundResult"/> if the category does not exist.
    /// </returns>
    [HttpPut]
    public IActionResult UpdateCategory(int id, [FromBody] Category category)
    {
        var existingCategory = _context.Categories.Find(id);

        if (existingCategory is not null)
        {
            return NotFound("Category not found.");
        }

        existingCategory.Name = category.Name;
        existingCategory.Description = category.Description;

        _context.Categories.Update(existingCategory);
        _context.SaveChanges();

        return Ok("Category updated successfully.");
    }

    /// <summary>
    /// Deletes a category from the database.
    /// </summary>
    /// <param name="id">The unique identifier of the category to delete.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> indicating the result of the delete operation.
    /// Returns <see cref="OkResult"/> if the deletion is successful; otherwise, <see cref="NotFoundResult"/> if the category does not exist.
    /// </returns>
    [HttpDelete]
    public async Task<IActionResult> DeleteCategory([FromQuery] int id)
    {
        var category = await _context.Categories.FindAsync(id);

        if (category == null)
        {
            return NotFound("Category not found.");
        }

        _context.Categories.RemoveRange([category]);
        await _context.SaveChangesAsync();

        return Ok("Category deleted successfully.");
    }
}
