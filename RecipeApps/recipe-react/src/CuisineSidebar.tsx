import CuisineCard from "./CuisineCard";
import { useState, useEffect } from "react";
import { ICuisine } from "./DataInterfaces";
import { fetchCuisine } from "./DataUtil";

export default function CuisineSidebar() {
  const [cuisineList, setCuisineList] = useState<ICuisine[]>([]);

  useEffect(() => {
    const fetchCuisineData = async () => {
      const data = await fetchCuisine();
      setCuisineList(data);
    };
    fetchCuisineData();
  }, []);
  return (
    <>
      {cuisineList.map((c) => (
        <CuisineCard key={c.cuisineID} cuisine={c} />
      ))}
    </>
  );
}
