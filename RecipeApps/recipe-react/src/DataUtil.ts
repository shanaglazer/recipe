import {ICuisine, IRecipe} from "./DataInterfaces";

const baseurl='http://localhost:5166/api/';  //'https://sgrecipeapi.azurewebsites.net/api/';

async function fetchData<T>(url:string):Promise<T> {
    url = baseurl + url;
    const r = await fetch(url);
    const data = await r.json();
    return data;
}

export async function fetchCuisine() {
    return await fetchData<ICuisine[]>('recipe/cuisineget')
}


export async function fetchRecipe(id: number) {
    return await fetchData<IRecipe[]>(`Recipe/searchbycuisine/${id}`)
}