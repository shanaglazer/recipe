export interface ICuisine {
    cuisineID: number;
    cuisineType: string;
}

export interface IRecipe {
    recipeId: number;
    usersId: number;
    cuisineId: number;
    recipeName: string;
    userName: string;
    cuisineType: string;
    calories: number;
    numIngredient: number;
    dateCreated: string; 
    dateArchived: string;
    datePublished: string;
    recipeStatus: string;
    vegan: boolean;
  }