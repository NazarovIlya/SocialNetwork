export interface Activeness {
  id: number;
  title: string;
  category: string;
  description: string;
  city: string;
  pointTime: Date;
  location: string;
}

interface Props {
  activeness: Activeness;
}
export function activenessComponent({ activeness }: Props) {
  return (
    <ul>
      <li>{activeness.id}</li>
      <li>{activeness.title}</li>
      <li>{activeness.category}</li>
      <li>{activeness.description}</li>
      <li>{activeness.city}</li>
      <li>{activeness.pointTime.getDate()}</li>
      <li>{activeness.location}</li>
    </ul>
  );
}
