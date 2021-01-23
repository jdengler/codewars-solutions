//https://www.codewars.com/kata/536e9a7973130a06eb000e9f

int calculate_damage(const char *your_type, const char *opponent_type, int attack, int defense) {
    int c = -1;
    switch(your_type[0])
    {
      case('f'): c=0; break;
      case('w'): c=1; break;
      case('g'): c=2; break;
      case('e'): c=3; break;
    }

    int r = -1;
    switch(opponent_type[0])
    {
      case('f'): r=0; break;
      case('w'): r=1; break;
      case('g'): r=2; break;
      case('e'): r=3; break;
    }

    double eff[4][4] = {{0.5, 2.0, 0.5, 1.0},
                        {0.5, 0.5, 2.0, 2.0},
                        {2.0, 0.5, 0.5, 1.0},
                        {1.0, 0.5, 1.0, 0.5}};

    return 50 * (attack / defense) * eff[r][c];
}
