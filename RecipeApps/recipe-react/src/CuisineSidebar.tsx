import CuisineCard from "./CuisineCard";
import { useState, useEffect } from "react";
import { ICuisine } from "./DataInterfaces";
import { fetchCuisine } from "./DataUtil";

interface Props {
  onCuisineSelected: (cuisineid: number) => void;
}

export default function CuisineSidebar({ onCuisineSelected }: Props) {
  const [cuisineList, setCuisineList] = useState<ICuisine[]>([]);
  const [selectedCuisineId, setSelectedCuisineId] = useState(0);

  useEffect(() => {
    const fetchCuisineData = async () => {
      const data = await fetchCuisine();
      setCuisineList(data);
      if (data.length > 0) {
        handleSelectedCuisin(data[0].cuisineID);
      }
    };
    fetchCuisineData();
  }, []);

  function handleSelectedCuisin(cuisineid: number) {
    setSelectedCuisineId(cuisineid);
    onCuisineSelected(cuisineid);
  }

  return (
    <>
      {/* <div className="d-flex flex-wrap"> */}
      {cuisineList.map((c) => (
        <CuisineCard
          key={c.cuisineID}
          cuisine={c}
          onSelected={handleSelectedCuisin}
          isSelected={c.cuisineID == selectedCuisineId}
        />
      ))}
      {/* </div> */}
    </>
  );
}
