import { FieldValues } from "react-hook-form";
import {ICuisine, IRecipe, IUsers} from "./DataInterfaces";

const baseurl=import.meta.env.VITE_API_URL;

async function fetchData<T>(url:string):Promise<T> {
    url = baseurl + url;
    const r = await fetch(url);
    const data = await r.json();
    return data;
}

export async function fetchCuisine() {
    return await fetchData<ICuisine[]>('recipe/cuisineget')
}

export async function fetchCuisineWithBlank() {
    return await fetchData<ICuisine[]>('recipe/blank/cuisineget')
}

export async function fetchRecipe(id: number) {
    return await fetchData<IRecipe[]>(`Recipe/searchbycuisine/${id}`)
}

export async function fetchUsers() {
    return await fetchData<IUsers[]>('recipe/users')
}

async function postData<T>(url:string, form:FieldValues): Promise<T>{
    url = baseurl + url;
    const r = await fetch(url, {
        method: "POST",
        body: JSON.stringify(form),
        headers: {
            "Content-Type": "application/json"
        }
    });
    const data = await r.json();
    return data;
}

async function deleteData<T>(url:string): Promise<T>{
    url = baseurl + url;
    const r = await fetch(url, {
        method: "DELETE"
    });
    const data = await r.json();
    return data;
}

export async function postRecipe(form:FieldValues) {
    return postData<IRecipe>("Recipe", form);
}

export async function deleteRecipe(recipeid:number){
    return deleteData<IRecipe>(`recipe?id=${recipeid}`);

}


export const blankrecipe: IRecipe = {
    recipeId: 0,
    usersId: 0,
    cuisineId: 0,
    userName: "",
    cuisineType: "",
    recipeName: "",
    calories: 0,
    dateCreated: "",
    datePublished: "",
    dateArchived: "",
    recipeStatus: "",
    vegan: false,
    errorMessage: "",
  };